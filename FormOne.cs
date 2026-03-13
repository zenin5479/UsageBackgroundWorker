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
   }
}