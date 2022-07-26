using System;
using System.Windows.Forms;

namespace socket_client
{

    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            AsynchronousClient.StartClient();
        }
    }
}
