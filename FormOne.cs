using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace UsageBackgroundWorker
{
   public partial class FormOne : Form
   {
      private BackgroundWorker backgroundWorker;
      private int iterationCount = 0;

      public FormOne()
      {
         InitializeComponent();

         InitializeBackgroundWorker();
         // Подписка на события
         //backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
         //backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
      }

      private void InitializeBackgroundWorker()
      {
         backgroundWorker = new BackgroundWorker
         {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
         };

         backgroundWorker.DoWork += BackgroundWorker_DoWork;
         backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
         backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
      }

      // Событие DoWork выполняется в фоновом потоке
      private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
      {
         BackgroundWorker worker = sender as BackgroundWorker;

         // Бесконечный цикл, пока не запрошена отмена
         while (!worker.CancellationPending)
         {
            // Имитация длительных вычислений (например, ресурсоёмкая операция)
            // Здесь можно разместить любой код расчётов
            iterationCount++;

            // Сообщаем прогресс (передаём текущее значение счётчика)
            worker.ReportProgress(0, iterationCount);

            // Небольшая задержка, чтобы не перегружать процессор и дать время на обработку отмены
            // В реальном приложении вместо Sleep может быть реальная работа
            Thread.Sleep(100);
         }

         // Если цикл прерван по отмене, устанавливаем флаг в e.Cancel
         e.Cancel = true;
      }

      // Событие ProgressChanged выполняется в потоке UI
      private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
      {
         // Получаем переданное значение
         int currentIteration = (int)e.UserState;
         resultLabel.Text = $"Итераций: {currentIteration}";
      }

      // Событие RunWorkerCompleted выполняется в потоке UI после завершения DoWork
      private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         if (e.Cancelled)
         {
            MessageBox.Show("Расчёты остановлены пользователем.", "Отмена",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else if (e.Error != null)
         {
            MessageBox.Show($"Ошибка: {e.Error.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            // Обычно сюда не попадём, так как цикл бесконечный и завершается только по отмене
            MessageBox.Show("Расчёты завершены.", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

         // Включаем кнопку Start, отключаем Stop
         buttonStart.Enabled = true;
         buttonStop.Enabled = false;
      }

      private void startButton_Click(object sender, EventArgs e)
      {
         if (!backgroundWorker.IsBusy)
         {
            iterationCount = 0; // Сброс счётчика
            backgroundWorker.RunWorkerAsync();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
         }

      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         if (backgroundWorker.IsBusy)
         {
            backgroundWorker.CancelAsync();
            buttonStop.Enabled = false;
         }
      }
   }
}