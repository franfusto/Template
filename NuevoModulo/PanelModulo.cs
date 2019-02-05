using System;
using horizonte;
using Gtk;
using Gdk;
using NGettext;

namespace NuevoModulo
{
	public static class Tr
	{
		public static  ICatalog Catalog = new Catalog("NuevoModulo", "./locale");
	}
	public class PanelModulo : iModuloHorizonte
	{
		Gtk.Widget _MainForm;
		Widget _ConfigForm;

		public PanelModulo ()
		{
		}

		#region iModuloHorizonte implementation
		public string ModId ()
		{
			return string.Empty;
		}
		public bool Init ()
		{
			return true;
		}

		public bool SetUp (string SetUpParam)
		{
			return true;
		}

		public bool Delete (string DeleteParam)
		{
			return true;
		}

		public Gtk.Widget ConfigForm ()
		{
			try {
				_ConfigForm = new wConfigForm();
				return _ConfigForm;	
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
				return null;	
			}

		}

		public Gtk.Widget MainForm ()
		{
			try {
				_MainForm = new wMainForm();
				return _MainForm;	
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
				return null;
			}

		}



		#endregion
	}
}

