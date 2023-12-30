using Cleaner.Core.Const;
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

            var messages = this._messageQueueService.GetMessages();
            this.RTB_Log.AppendText($"Start - {DateTime.UtcNow}" + Environment.NewLine);
            foreach (var item in messages) 
                this.RTB_Log.AppendText(item + Environment.NewLine);
            this.RTB_Log.AppendText($"End -  {DateTime.UtcNow}" + Environment.NewLine);
        }

        #region " Methods "
        private void Tasks()
        {
            this._cleanService.RunCleaning(folderPath: PathsToClean.APP_DATA.USERTEMP);
            this._cleanService.RunCleaning(folderPath: PathsToClean.APP_DATA.MICROSOFT_EDGE);
        }
        #endregion
    }
}
