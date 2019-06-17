using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace LiveChartsWinFormCSharp
{
    public partial class FormMain : Form
    {
        private int[] m_nHistgram;

        public FormMain()
        {
            InitializeComponent();

            m_nHistgram = new int[256];

            InitGraph();
        }

        private void OnClickBtnFileSelect(object sender, EventArgs e)
        {
            ComOpenFileDialog openFileDlg = new ComOpenFileDialog();
            openFileDlg.Filter = "JPG|*.jpg|PNG|*.png";
            openFileDlg.Title = "Open the file";
            if (openFileDlg.ShowDialog() == true)
            {
                image.Image = null;
                var bitmap = new Bitmap(openFileDlg.FileName);
                image.Image = bitmap;

                DrawHistgram(bitmap);
            }
            return;
        }

        public void InitGraph()
        {
            LineSeries lineSeriesChart = new LineSeries()
            {
                Values = new ChartValues<int>(),
                Title = "Histgram"
            };

            for (int nIdx = 0; nIdx < 256; nIdx++)
            {
                lineSeriesChart.Values.Add(0);
            }
            chart.Series.Clear();
            chart.Series.Add(lineSeriesChart);

            return;
        }

        public void DrawHistgram(Bitmap _bitmap)
        {
            InitHistgram();

            CalHistgram(_bitmap);

            LineSeries lineSeriesChart = new LineSeries()
            {
                Values = new ChartValues<int>(),
                Title = "Histgram"
            };

            for (int nIdx = 0; nIdx < 256; nIdx++)
            {
                lineSeriesChart.Values.Add(m_nHistgram[nIdx]);
            }
            chart.Series.Clear();
            chart.Series.Add(lineSeriesChart);

            return;
        }

        public void CalHistgram(Bitmap _bitmap)
        {
            int nWidthSize = _bitmap.Width;
            int nHeightSize = _bitmap.Height;

            BitmapData bitmapData = _bitmap.LockBits(new Rectangle(0, 0, nWidthSize, nHeightSize), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int nIdxWidth;
            int nIdxHeight;

            unsafe
            {
                for (nIdxHeight = 0; nIdxHeight < nHeightSize; nIdxHeight++)
                {
                    for (nIdxWidth = 0; nIdxWidth < nWidthSize; nIdxWidth++)
                    {
                        byte* pPixel = (byte*)bitmapData.Scan0 + nIdxHeight * bitmapData.Stride + nIdxWidth * 4;
                        byte nGrayScale = (byte)((pPixel[(int)ComInfo.Pixel.B] + pPixel[(int)ComInfo.Pixel.G] + pPixel[(int)ComInfo.Pixel.R]) / 3);

                        m_nHistgram[nGrayScale] += 1;
                    }
                }
                _bitmap.UnlockBits(bitmapData);
            }
        }

        public void InitHistgram()
        {
            for (int nIdx = 0; nIdx < 256; nIdx++)
            {
                m_nHistgram[nIdx] = 0;
            }
        }
    }
}