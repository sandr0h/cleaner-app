using Cleaner.Core.Services;
using Cleaner.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cleaner_app
{
    public partial class MainForm : Form
    {
        private readonly ICleanService _cleanService;
        private readonly IMessageQueueService _messageQueueService;
        public MainForm(ICleanService cleanService, IMessageQueueService messageQueueService)
        {
            this._cleanService = cleanService;
            this._messageQueueService = messageQueueService;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tasks();

            var teste = this._messageQueueService.GetMessages();
            foreach (var item in teste)
            {
                this.RTB_Log.AppendText(item + Environment.NewLine);
            }
        }

        #region " Methods "
        private void Tasks()
        {
            this._cleanService.RunCleaning(folderPath: Path.GetTempPath());
        }
        #endregion
    }
}
