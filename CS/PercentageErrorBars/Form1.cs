using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ErrorBarsWin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Series series { get { return chartControl.Series[0]; } }
        #region #PercentageErrorBars
        private void FormOnLoad(object sender, EventArgs e) {
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            PointSeriesView view = (PointSeriesView)chartControl.Series[0].View;
            view.Indicators.Add(new PercentageErrorBars {
                Percent = 10,
                Direction = ErrorBarDirection.Both,
                ShowInLegend = true,
                Name = "Units on Custom Order"
            });
        }
        #endregion #PercentageErrorBars
    }
}
