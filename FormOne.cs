using System.Windows.Forms;
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
         backgroundWorker1.WorkerReportsProgress = true;
         backgroundWorker1.WorkerSupportsCancellation = true;

         // Подписка на события
         backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
         backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
         backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
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

         e.Cancel = true; // Указываем, что работа отменена
      }

      private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         // Обновление интерфейса из основного потока
         double result = (double)e.UserState;
         resultLabel.Text = $"Результат: {result:F2}";
         progressBar.Increment(1);
      }

      private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         // Восстановление состояния кнопок
         startButton.Enabled = true;
         stopButton.Enabled = false;

         if (e.Cancelled)
         {
            resultLabel.Text = "Расчёты остановлены";
         }
         else if (e.Error != null)
         {
            resultLabel.Text = $"Ошибка: {e.Error.Message}";
         }
      }
   }
}