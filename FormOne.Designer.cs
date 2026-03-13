namespace UsageBackgroundWorker
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         StartButton = new System.Windows.Forms.Button();
         StopButton = new System.Windows.Forms.Button();
         ProgressBarOne = new System.Windows.Forms.ProgressBar();
         ResultLabel = new System.Windows.Forms.Label();
         BackgroundWorkerOne = new System.ComponentModel.BackgroundWorker();
         SuspendLayout();
         // 
         // StartButton
         // 
         StartButton.Location = new System.Drawing.Point(12, 12);
         StartButton.Name = "StartButton";
         StartButton.Size = new System.Drawing.Size(150, 23);
         StartButton.TabIndex = 0;
         StartButton.Text = "Запустить расчёты";
         StartButton.UseVisualStyleBackColor = true;
         StartButton.Click += StartButton_Click;
         // 
         // StopButton
         // 
         StopButton.Location = new System.Drawing.Point(12, 41);
         StopButton.Name = "StopButton";
         StopButton.Size = new System.Drawing.Size(150, 23);
         StopButton.TabIndex = 1;
         StopButton.Text = "Остановить расчёты";
         StopButton.UseVisualStyleBackColor = true;
         StopButton.Click += StopButton_Click;
         // 
         // ProgressBarOne
         // 
         ProgressBarOne.Location = new System.Drawing.Point(168, 12);
         ProgressBarOne.Name = "ProgressBarOne";
         ProgressBarOne.Size = new System.Drawing.Size(250, 23);
         ProgressBarOne.TabIndex = 2;
         // 
         // ResultLabel
         // 
         ResultLabel.AutoSize = true;
         ResultLabel.Location = new System.Drawing.Point(12, 67);
         ResultLabel.Name = "ResultLabel";
         ResultLabel.Size = new System.Drawing.Size(78, 15);
         ResultLabel.TabIndex = 3;
         ResultLabel.Text = "Результат: —";
         // 
         // BackgroundWorkerOne
         // 
         BackgroundWorkerOne.WorkerReportsProgress = true;
         BackgroundWorkerOne.WorkerSupportsCancellation = true;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(431, 102);
         Controls.Add(ResultLabel);
         Controls.Add(ProgressBarOne);
         Controls.Add(StopButton);
         Controls.Add(StartButton);
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Использование BackgroundWorker в Windows Forms";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button StartButton;
      private System.Windows.Forms.Button StopButton;
      private System.Windows.Forms.ProgressBar ProgressBarOne;
      private System.Windows.Forms.Label ResultLabel;
      private System.ComponentModel.BackgroundWorker BackgroundWorkerOne;
   }
}