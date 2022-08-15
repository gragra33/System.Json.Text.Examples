using System.Collections;
using WinFormSimpleCollection.ViewModels;

namespace WinFormSimpleCollection
{
    public partial class Form1 : Form
    {
        private readonly MainViewModel vm = new();
        private const string txtPropName = nameof(TextBox.Text);

        public Form1()
        {
            InitializeComponent();
            InitializeDataBindings();
        }

        private void InitializeDataBindings()
        {
            BindList(lbCategories, vm.Categories, "Name", "Id");

            BindField(gbCategory, txtPropName, "FormattedId", vm.Categories);
            BindField(txtName, txtPropName, "Name", vm.Categories);
            BindField(txtMetaTitle, txtPropName, "MetaTitle", vm.Categories);
            BindField(txtMetaKeywords, txtPropName, "MetaKeywords", vm.Categories);
            BindField(txtMetaDescription, txtPropName, "MetaDescription", vm.Categories);
            BindField(txtPageDescription, txtPropName, "PageDescription", vm.Categories);
            BindField(txtPageTitle, txtPropName, "PageTitle", vm.Categories);
            BindField(txtCategoryName, txtPropName, "CategoryName", vm.Categories);
            BindField(txtShortName, txtPropName, "ShortName", vm.Categories);
            BindField(txtLongName, txtPropName, "LongName", vm.Categories);
            BindField(txtNumChildren, txtPropName, "NumChildren", vm.Categories);
        }

        private void BindField(Control ctrl,  string ctrlProp, string modelProp, IList source)
        {
            // uncomment for editing
            //ctrl.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            ctrl.DataBindings.Add(ctrlProp, source, modelProp, true);
        }

        public static void BindList<TModel>(ListControl ctrl, IList<TModel> dataSource, string displayMember, string valueMember)
        {
            ctrl.DisplayMember = displayMember;
            ctrl.ValueMember = valueMember;
            ctrl.DataSource = dataSource;
        }

        private void GetDataClicked(object sender, EventArgs e)
            => vm.HandleClicked();
    }
}