using Entidades;

namespace WinFormsCRUD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmLogin());

            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            int cantidad_intentos = 0;

            try
            {
                frm.ShowDialog();

                do
                {
                    if (cantidad_intentos == 3 && frm.UsuarioDelForm == null)
                    {
                        MessageBox.Show("Superaste la cantidad de intentos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        break;
                    }
                    else if (frm.UsuarioDelForm == null)
                    {
                        try
                        {
                            throw new UsuarioErroneoExcepcion();
                        }
                        catch (UsuarioErroneoExcepcion ex)
                        {
                            MessageBox.Show(UsuarioErroneoExcepcion.RetornarInformacionDelError(ex),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}\nComuniquese con sistemas", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        frm.ShowDialog();
                    }

                    cantidad_intentos++;


                } while (cantidad_intentos < 4 && frm.DialogResult != DialogResult.Cancel);
                
                if (frm.UsuarioDelForm != null) 
                {
                    FrmPrincipal frmAplicacion = new FrmPrincipal(frm.UsuarioDelForm);
                    frmAplicacion.StartPosition = FormStartPosition.CenterScreen;
                    Application.Run(frmAplicacion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Se cerró la aplicación", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}