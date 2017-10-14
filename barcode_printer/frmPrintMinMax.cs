using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace barcode_printer {
    public partial class frmPrintMinMax : Form {
        public frmPrintMinMax() {
            InitializeComponent();
            //dataConfig.loadConfig();
            tbMin.Text = dataConfig.print_min_val.ToString();
            tbMax.Text = dataConfig.print_max_val.ToString();
        }
        private void btnOK_Click(object sender, EventArgs e) {
            int max = 0;
            if (tbMax.Text != "") {
                max = int.Parse(tbMax.Text.Trim());
            }
            int min = 0;
            if (tbMin.Text != "") {
                min = int.Parse(tbMin.Text.Trim());
            }
            if (max <= min) {
                MessageBox.Show("上限必须大于下限值!");
                return;
            } else if (max < 0 || min < 0) {
                MessageBox.Show("上下限值必须大于0!");
                return;
            } else if (min <= 0) {
                MessageBox.Show("下限必须大于等于1!");
                return;
            }
            dataConfig.print_max_val = max;
            dataConfig.print_min_val = min;
            dataConfig.saveParamMinMax();
            this.Close();
        }
    }
}