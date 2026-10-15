using System.Diagnostics;
using System.Drawing.Imaging;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static UdpTableReader;

namespace TCPView {

	public partial class Form1:Form {
		public Form1() {
			InitializeComponent();
		}

		System.Windows.Forms.Timer? winTimer;
		System.Windows.Forms.Timer? DeleteTimer;
		IEnumerable<MIB_TCPROW_OWNER_PID>? TcpV4;
		IEnumerable<MIB_TCP6ROW_OWNER_PID>? TcpV6;
		List<MIB_UDPROW_OWNER_PID>? GetExtendedUdpTable4;
		List<MIB_UDP6ROW_OWNER_PID>? GetExtendedUdpTable6;


		private void Form1_Load(object sender,EventArgs e) {
					
					winTimer = new System.Windows.Forms.Timer();
					winTimer.Interval = 2000;
					winTimer.Tick += async (s,e) => {
								await timerTcpV4Tick();
								await timerTcpV6Tick();
								await timerUcpV4Tick();
								await timerUcpV6Tick();
					};
					winTimer.Start();

					DeleteTimer = new System.Windows.Forms.Timer();
					DeleteTimer.Interval = 5000;
					DeleteTimer.Tick += async (s,e) => {
						await DeleteTick();
					};
					DeleteTimer.Start();
				
		}
		private void Form1_FormClosing(object sender,FormClosingEventArgs e) {
					winTimer?.Stop();
					DeleteTimer?.Stop();
		}

		#region  TcpV4

		public async Task timerTcpV4Tick() {
			TcpV4 = TcpTableV4.GetAllTcpConnections();
			foreach(var row in TcpV4) {

				this.Invoke(new Action(() => {

					bool isExist = dataGridView1.Rows.Cast<DataGridViewRow>()
						.Where(r => !r.IsNewRow) // 排除最下方供新增用的空白行
						.Any(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == row.ProcessId.ToString());
					//Trace.WriteLine($"Local: {row.LocalEndPoint} -> Remote: {row.RemoteEndPoint}");
					if(!isExist) {
									dataGridView1.Rows.Add(
												TcpUdpStateInfo.AddProcessIcon((int)row.ProcessId),
												row.ProcessName,
												row.ProcessId,
												row.LocalAddress,
												row.LocalPort,
												row.RemoteAddress,
												row.RemotePort,
												TcpUdpStateInfo.TcpState(row.State.ToString()),
												TcpUdpStateInfo.GetProcessPath((int)row.ProcessId)
									);
					} else {

								var targetRow = dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[2].Value.ToString() == row.ProcessId.ToString());
								int rowIndex = targetRow.Index; // 取得 Index
								Trace.WriteLine(row.State.ToString());
								if(targetRow != null) {
											dataGridView1.Rows[rowIndex].Cells[7].Value = TcpUdpStateInfo.TcpState(row.State.ToString());
											dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = TcpUdpStateInfo.GetTcpStateColor(TcpUdpStateInfo.TcpState(row.State.ToString()));
											dataGridView1.EndEdit();
								}
					}

				}));


			}
			Statistics();
		}
		#endregion

		#region  TcpV6
		private async Task timerTcpV6Tick() {


			TcpV6 = TcpTableV6.GetAllTcpConnections();

			foreach(var row in TcpV6) {

				this.Invoke(new Action(() => {

					bool isExist = dataGridView2.Rows.Cast<DataGridViewRow>()
						.Where(r => !r.IsNewRow) // 排除最下方供新增用的空白行
						.Any(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == row.owningPid.ToString());
					//Trace.WriteLine($"Local: {row.LocalEndPoint} -> Remote: {row.RemoteEndPoint}");

					var localIp = new IPAddress(row.localAddr);
					var remoteIp = new IPAddress(row.remoteAddr);
					if(!isExist) {
						dataGridView2.Rows.Add(
									TcpUdpStateInfo.AddProcessIcon((int)row.owningPid),
									row.ProcessName,
									row.owningPid,
									localIp,
									row.LocalPort,
									remoteIp,
									row.RemotePort,
									TcpUdpStateInfo.TcpState(row.state.ToString()),
									TcpUdpStateInfo.GetProcessPath((int)row.owningPid)
						);
					} else {

						var targetRow = dataGridView2.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells[2].Value.ToString() == row.owningPid.ToString());
						int rowIndex = targetRow.Index; // 取得 Index
						if(targetRow != null) {
							//Trace.WriteLine(row.state.ToString());
							dataGridView2.Rows[rowIndex].Cells[7].Value = TcpUdpStateInfo.TcpState(row.state.ToString());
							dataGridView2.Rows[rowIndex].DefaultCellStyle.BackColor = TcpUdpStateInfo.GetTcpStateColor(TcpUdpStateInfo.TcpState(row.state.ToString()));
							dataGridView2.EndEdit();
						}
					}

				}));


			}

			Statistics();

		}
		#endregion

		#region UcpV4
		private async Task timerUcpV4Tick() {
			GetExtendedUdpTable4 = UdpTableReader.GetExtendedUdpTable4();
			foreach(var row in UdpTableReader.GetExtendedUdpTable4()) {

				this.Invoke(new Action(() => {

					bool isExist = dataGridView3.Rows.Cast<DataGridViewRow>()
						.Where(r => !r.IsNewRow) // 排除最下方供新增用的空白行
						.Any(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == row.owningPid.ToString());
					//Trace.WriteLine($"Local: {row.LocalEndPoint} -> Remote: {row.RemoteEndPoint}");
					if(!isExist) {
						dataGridView3.Rows.Add(
									TcpUdpStateInfo.AddProcessIcon((int)row.owningPid),
									TcpUdpStateInfo.GetProcessName((int)row.owningPid),
									row.owningPid,
									row.LocalAddress,
									row.LocalPort,
									"*",
									"*",
									"*",
									TcpUdpStateInfo.GetProcessPath((int)row.owningPid)
						);
					}

				}));
			}

		}
		#endregion

		#region UcpV6
		private async Task timerUcpV6Tick() {

			GetExtendedUdpTable6 = UdpTableReader.GetExtendedUdpTable6();

			foreach(var row in GetExtendedUdpTable6) {

				this.Invoke(new Action(() => {

					bool isExist = dataGridView4.Rows.Cast<DataGridViewRow>()
						.Where(r => !r.IsNewRow) // 排除最下方供新增用的空白行
						.Any(r => r.Cells[2].Value != null && r.Cells[2].Value.ToString() == row.owningPid.ToString());
					//Trace.WriteLine($"Local: {row.LocalEndPoint} -> Remote: {row.RemoteEndPoint}");
					if(!isExist) {
						dataGridView4.Rows.Add(
									TcpUdpStateInfo.AddProcessIcon((int)row.owningPid),
									TcpUdpStateInfo.GetProcessName((int)row.owningPid),
									row.owningPid,
									row.LocalAddress,
									row.LocalPort,
									"*",
									"*",
									"*",
									TcpUdpStateInfo.GetProcessPath((int)row.owningPid)
						);
					}

				}));
			}

		}
		#endregion

		#region  DeleteTick
		public async Task DeleteTick() {

			var rows1ToDelete = dataGridView1.Rows.Cast<DataGridViewRow>()
				.Where(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSED" || r.Cells[7].Value?.ToString() == "CLOSE_WAIT")
				.ToList();

			foreach(var row1 in rows1ToDelete) {
				dataGridView1.Rows.Remove(row1);
			}

			var rows2ToDelete = dataGridView2.Rows.Cast<DataGridViewRow>()
				.Where(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSED" || r.Cells[7].Value?.ToString() == "CLOSE_WAIT")
				.ToList();

			foreach(var row2 in rows2ToDelete) {
				dataGridView2.Rows.Remove(row2);
			}


			Statistics();
		}
		#endregion

		#region 統計
		public void Statistics() {
			//全部端點 Endpoints 
			int Endpoints1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString().Length > 0);
			int Established1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "ESTABLISHED");
			int Llistening1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "LISTENING");
			int time_wait1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "TIME_WAIT");
			int Closewait1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSE_WAIT");
			int closing1count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSING");

			int Endpoints2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString().Length > 0);
			int Established2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "ESTABLISHED");
			int Llistening2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "LISTENING");
			int time_wait2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "TIME_WAIT");
			int Closewait2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSE_WAIT");
			int closing2count = dataGridView2.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow && r.Cells[7].Value?.ToString() == "CLOSING");
			/*
			toolStripStatusLabel1.Text = "Endpoints：" + (Endpoints1count + Endpoints2count).ToString();
			toolStripStatusLabel2.Text = "Established：" + (Established1count + Established2count).ToString();
			toolStripStatusLabel3.Text = "Llistening：" + (Llistening1count + Llistening2count).ToString();
			toolStripStatusLabel4.Text = "Time_wait：" + (time_wait1count + time_wait2count).ToString();
			toolStripStatusLabel5.Text = "Close_wait：" + (Closewait1count + Closewait2count).ToString();
			toolStripStatusLabel6.Text = "Closing：" + (closing1count + closing2count).ToString();
			*/

			toolStripStatusLabel1.Text = "全部端點：" + (Endpoints1count + Endpoints2count).ToString();
			toolStripStatusLabel2.Text = "已建立：" + (Established1count + Established2count).ToString();
			toolStripStatusLabel3.Text = "監聽中：" + (Llistening1count + Llistening2count).ToString();
			toolStripStatusLabel4.Text = "等待時間：" + (time_wait1count + time_wait2count).ToString();
			toolStripStatusLabel5.Text = "關閉等待：" + (Closewait1count + Closewait2count).ToString();
			toolStripStatusLabel6.Text = "已結束：" + (closing1count + closing2count).ToString();
			System.GC.Collect();
		}
		#endregion

		#region 結束進程
		private void toolStripMenuItem1_Click(object sender,EventArgs e) {

			try {
				string? val = "";
				if(tabControl1.SelectedIndex == 0) {
					val = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				} else if(tabControl1.SelectedIndex == 1) {
					val = dataGridView2.CurrentRow.Cells[1].Value.ToString();
				} else if(tabControl1.SelectedIndex == 2) {
					val = dataGridView3.CurrentRow.Cells[1].Value.ToString();
				} else if(tabControl1.SelectedIndex == 3) {
					val = dataGridView4.CurrentRow.Cells[1].Value.ToString();
				}

				if(MessageBox.Show("您確定要" + val + "結束進程嗎？","訊息",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK) {

					foreach(var process in Process.GetProcessesByName(val)) {
						process.Kill();
						process.WaitForExit();
					}


					if(tabControl1.SelectedIndex == 0) {
						if(dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow) {
							dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
						}
					} else if(tabControl1.SelectedIndex == 1) {
						if(dataGridView2.CurrentRow != null && !dataGridView2.CurrentRow.IsNewRow) {
							dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
						}
					} else if(tabControl1.SelectedIndex == 2) {
						if(dataGridView3.CurrentRow != null && !dataGridView3.CurrentRow.IsNewRow) {
							dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
						}
					} else if(tabControl1.SelectedIndex == 3) {
						if(dataGridView4.CurrentRow != null && !dataGridView4.CurrentRow.IsNewRow) {
							dataGridView4.Rows.Remove(dataGridView4.CurrentRow);
						}
					}
					Statistics();

				}

			} catch(Exception ex) {
				MessageBox.Show("結束進程異常：" + ex.Message,"訊息",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
			}
		}
		#endregion

		#region  復製
		private void toolStripMenuItem2_Click(object sender,EventArgs e) {

			string? val = "";
			if(tabControl1.SelectedIndex == 0) {
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString() + "\n";
				val += dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString() + "\n";
			} else if(tabControl1.SelectedIndex == 1) {
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].Value.ToString() + "\n";
				val += dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].Value.ToString() + "\n";
			} else if(tabControl1.SelectedIndex == 2) {
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[2].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[4].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[5].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[6].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[7].Value.ToString() + "\n";
				val += dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[8].Value.ToString() + "\n";
			} else if(tabControl1.SelectedIndex == 3) {
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[1].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[2].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[3].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[4].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[5].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[6].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[7].Value.ToString() + "\n";
				val += dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[8].Value.ToString() + "\n";
			}

			Clipboard.Clear();
			Clipboard.SetDataObject(val,true);

			MessageBox.Show("復製完成","訊息",MessageBoxButtons.OK,MessageBoxIcon.Information);

		}
		#endregion

		#region searchBox
		private async void textBox1_KeyUp(object sender,KeyEventArgs e) {
				
				if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Space || (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) {

						if(searchBox.Text.Trim().Length > 0) {

										winTimer.Stop();
										DeleteTimer.Stop();
										dataGridView1.Rows.Clear();
										dataGridView2.Rows.Clear();
										dataGridView3.Rows.Clear();
										dataGridView4.Rows.Clear();
										await Task.Run(() => {
												this.Invoke(new Action(() => {

														TcpV4.Where(x => x.ProcessName.Contains(searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {
																		dataGridView1.Rows.Add(
																				TcpUdpStateInfo.AddProcessIcon((int)x.ProcessId),
																				x.ProcessName,
																				x.ProcessId,
																				x.LocalAddress,
																				x.LocalPort,
																				x.RemoteAddress,
																				x.RemotePort,
																				TcpUdpStateInfo.TcpState(x.State.ToString()),
																				TcpUdpStateInfo.GetProcessPath((int)x.ProcessId)
																		);
														});

														TcpV6.Where(x => x.ProcessName.Contains(searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {

																		var localIp = new IPAddress(x.localAddr);
																		var remoteIp = new IPAddress(x.remoteAddr);
																		dataGridView2.Rows.Add(
																					TcpUdpStateInfo.AddProcessIcon((int)x.owningPid),
																					x.ProcessName,
																					x.owningPid,
																					localIp,
																					x.LocalPort,
																					remoteIp,
																					x.RemotePort,
																					TcpUdpStateInfo.TcpState(x.state.ToString()),
																					TcpUdpStateInfo.GetProcessPath((int)x.owningPid)
																		);
														});

														GetExtendedUdpTable4.Where(x => x.ProcessName.Contains(searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {
																				dataGridView3.Rows.Add(
																							TcpUdpStateInfo.AddProcessIcon((int)x.owningPid),
																							x.ProcessName,
																							x.owningPid,
																							x.LocalAddress,
																							x.LocalPort,
																							"*",
																							"*",
																							"*",
																							TcpUdpStateInfo.GetProcessPath((int)x.owningPid)
																				);
														});

														GetExtendedUdpTable6.Where(x => x.ProcessName.Contains(searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {

																				dataGridView4.Rows.Add(
																							TcpUdpStateInfo.AddProcessIcon((int)x.owningPid),
																							x.ProcessName,
																							x.owningPid,
																							x.LocalAddress,
																							x.LocalPort,
																							"*",
																							"*",
																							"*",
																							TcpUdpStateInfo.GetProcessPath((int)x.owningPid)
																				);

														});


												}));
										});
										Statistics();
						} else {
										
										dataGridView1.Rows.Clear();
										dataGridView2.Rows.Clear();
										dataGridView3.Rows.Clear();
										dataGridView4.Rows.Clear();
										await timerTcpV4Tick();
										await timerTcpV6Tick();
										await timerUcpV4Tick();
										await timerUcpV6Tick();

										winTimer?.Start();
										DeleteTimer?.Start();
						}

				}
		}
		#endregion

	}
}
