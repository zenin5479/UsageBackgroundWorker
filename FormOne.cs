using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace UsageBackgroundWorker
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();

         // Подписка на события
         //backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
         //backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
      }

      private void startButton_Click(object sender, EventArgs e)
      {
         BackgroundWorker worker = (BackgroundWorker)sender;
         int calculationCounter = 0;

         if (!backgroundWorker1.IsBusy)
         {
            backgroundWorker1.RunWorkerAsync();
            //startButton.Enabled = false;
            //stopButton.Enabled = true;
            

            while (!worker.CancellationPending)
            {
               // Имитация расчёта
               double result = Math.Sin(calculationCounter * 0.1) * 100;
               calculationCounter++;

               // Отчёт о прогрессе и передача результата
               worker.ReportProgress(0, result);

               // Пауза для демонстрации работы
               Thread.Sleep(200);

               // Обновление интерфейса из основного потока
               resultLabel.Text = string.Format("Результат: {0:F2}", result);
            }

            // Указываем, что работа отменена
            //e.Cancel = true;
         }

      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         if (backgroundWorker1.IsBusy)
         {
            backgroundWorker1.CancelAsync();
         }

         // Восстановление состояния кнопок
         //startButton.Enabled = true;
         //stopButton.Enabled = false;

         //if (e.Cancelled)
         //{
         //   resultLabel.Text = "Расчёты остановлены";
         //}
         //else if (e.Error != null)
         //{
         //   resultLabel.Text = string.Format("Ошибка: {0}", e.Error.Message);
         //}
      }
   }
}