// ** Article and associated source code originally published by Graeme Grant @ https://www.codeproject.com/Articles/5339651/Working-with-System-Text-Json-in-Csharp

using Support.CSharp.Json;
using WinFormSimpleObject.Models;

namespace WinFormSimpleObject;

public partial class Form1 : Form
{
    public Form1()
        => InitializeComponent();

    private void GetDataClicked(object sender, EventArgs e)
    {
        GetData();
        ((Button)sender).Enabled = false;
    }

    public Category? Result { get; set; }

    private const string fileName = "Etsy_Category.Json";
    private readonly string filePath = Environment.CurrentDirectory;

    private void GetData()
    {
        // Retrieve JSON data from file
        string rawJson = File.ReadAllText(Path.Combine(filePath, fileName));

        // Convert to C# Class typed object
        Result = JsonHelper.ToClass<Category>(rawJson);

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (Result is null)
            return;

        gbCategory.Text = $@"ID#: {Result.CategoryId}";
        txtName.Text = Result.Name;
        txtMetaTitle.Text = Result.MetaTitle;
        txtMetaKeywords.Text = Result.MetaKeywords;
        txtMetaDescription.Text = Result.MetaDescription;
        txtPageDescription.Text = Result.PageDescription;
        txtPageTitle.Text = Result.PageTitle;
        txtCategoryName.Text = Result.CategoryName;
        txtShortName.Text = Result.ShortName;
        txtLongName.Text = Result.LongName;
        txtNumChildren.Text = Result.NumChildren.ToString();
    }
}