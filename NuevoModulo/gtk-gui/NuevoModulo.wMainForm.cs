
// This file has been generated by the GUI designer. Do not modify.
namespace NuevoModulo
{
	public partial class wMainForm
	{
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NuevoModulo.wMainForm
			global::Stetic.BinContainer.Attach (this);
			this.Name = "NuevoModulo.wMainForm";
			// Container child NuevoModulo.wMainForm.Gtk.Container+ContainerChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::NuevoModulo.Tr.Catalog.GetString ("Widget principal");
			this.Add (this.label1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
