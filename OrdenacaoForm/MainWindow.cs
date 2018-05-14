using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	int[] y = {1, 3, 5, 2, 4, 78, 35, 38, 18};
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnOrdenarClicked (object sender, EventArgs e)
	{
		bubblesort (y);
		lblOrdenar.Text = "Itens do array ordenado";
		for (int i = 0; i < y.Length; i++) {
			lblOrdenar.Text += " " + y [i];
		}
	}

	public static void bubblesort(int[] y){
		for (int i = 1; i < y.Length; i++)
			for (int j = 0; j < y.Length - 1; j++)
				if (y [j] > y [j + 1])
					troca (y, j);             
	}

	public static void troca(int[] g, int primeiro){
		int aux;
		aux = g [primeiro];
		g[primeiro] = g[primeiro + 1];
		g[primeiro + 1] = aux;
	} 
}
