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

         // Настройка BackgroundWorker
         BackgroundWorkerOne.WorkerReportsProgress = true;
         BackgroundWorkerOne.WorkerSupportsCancellation = true;

         // Подписка на события
         BackgroundWorkerOne.DoWork += BackgroundWorker1_DoWork;
         BackgroundWorkerOne.ProgressChanged += BackgroundWorker1_ProgressChanged;
         BackgroundWorkerOne.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
      }

      private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
      {
         BackgroundWorker worker = sender as BackgroundWorker;
         int calculationCounter = 0;

         while (!worker.CancellationPending)
         {
            // Имитация расчёта
            double result = Math.Sin(calculationCounter * 0.1) * 100;
            calculationCounter++;

            // Отчёт о прогрессе и передача результата
            worker.ReportProgress(0, result);

            // Пауза для демонстрации работы
            Thread.Sleep(100);
         }

         // Указываем, что работа отменена
         e.Cancel = true;
      }

      private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         // Обновление интерфейса из основного потока
         double result = (double)e.UserState;
         ResultLabel.Text = string.Format("Результат: {0:F2}", result);
         ProgressBarOne.Increment(1);
      }

      private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         // Восстановление состояния кнопок
         StartButton.Enabled = true;
         StopButton.Enabled = false;

         if (e.Cancelled)
         {
            ResultLabel.Text = "Расчёты остановлены";
         }
         else if (e.Error != null)
         {
            ResultLabel.Text = string.Format("Ошибка: {0}", e.Error.Message);
         }
      }

      private void startButton_Click(object sender, EventArgs e)
      {
         if (!BackgroundWorkerOne.IsBusy)
         {
            BackgroundWorkerOne.RunWorkerAsync();
            StartButton.Enabled = false;
            StopButton.Enabled = true;
         }
      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         if (BackgroundWorkerOne.IsBusy)
         {
            BackgroundWorkerOne.CancelAsync();
         }
      }
   }
}