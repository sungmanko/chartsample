using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 챠트설정
        /// </summary>
        private void InitializeChart()
        {
            // Chart 설정 초기화
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // ChartArea 추가
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Series 추가
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            chart1.Series.Add(series);

            // 더미 데이터 추가 (예시)
            Random random = new Random();
            for (int year = 1980; year <= 2020; year += 10)
            {
                series.Points.AddXY(year, random.Next(100, 500));
            }

            // X축 설정
            chartArea.AxisX.Minimum = 1980;
            chartArea.AxisX.Maximum = 2020;
            chartArea.AxisX.Interval = 10;
            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Y축 설정
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // 제목 및 레이블 설정
            chartArea.AxisX.Title = "Year";
            chartArea.AxisY.Title = "Value";
            chart1.Titles.Add("ChartTitle").Text = "Data by Decades";
        }

        /// <summary>
        /// 폼로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeChart();
        }
    }
}
