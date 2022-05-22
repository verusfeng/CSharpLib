using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace CSharpLib
{
    public class LabelLog : Label
    {
        private NLog.Logger logger; //

        public LabelLog(string Name) : base()
        {
            this.Name = Name;
            //MessageBox.Show("Constructor..");
            logger = NLog.LogManager.GetLogger(this.Name);
            logger.Debug("Create a label logger ...");
            //MessageBox.Show("ONCreate ..");
            this.AutoSize = false;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public LabelLog() : this("LabelLog")
        {
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //
            throw new Exception("不可设计编辑。只能实例创建");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            //MessageBox.Show("TextChange..");
            logger.Debug(this.Text);

        }
        //public new string Text
        //{
        //    get
        //    {
        //        return base.Text;
        //    }
        //    set
        //    {
        //        base.Text = value;
        //        logger.Debug(value);
        //    }
        //}
    }
}
