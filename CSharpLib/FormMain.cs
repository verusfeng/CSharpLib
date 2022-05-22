using System.Windows.Forms;
namespace CSharpLib
{
    public class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LabelLogInitial();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(345, 182);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
        }
        #region  label log 
        private LabelLog logger;
        private void LabelLogInitial()
        {
            logger = new LabelLog();
            logger.Text = "Create Logger";
        }
        #endregion
        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.logger.Text = "Form Load ...";
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
        }
    }
}