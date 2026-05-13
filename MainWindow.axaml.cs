using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using SmartExpenseTrackerGUI.Models;
using SmartExpenseTrackerGUI.Services;

namespace SmartExpenseTrackerGUI;

public partial class MainWindow : Window
{
    private readonly FileService _fileService = new();
    private List<Transaction> _transactions = new();

    private readonly List<string> incomeCategories = new()
    {
        "Salary",
        "Freelance",
        "Gift",
        "Scholarship",
        "Other Income"
    };

    private readonly List<string> expenseCategories = new()
    {
        "Food",
        "Travel",
        "Shopping",
        "Bills",
        "Study",
        "Entertainment",
        "Other Expense"
    };

    public MainWindow()
    {
        InitializeComponent();

        _transactions = _fileService.LoadTransactions();

        TypeBox.SelectionChanged += TypeChanged;
        AddButton.Click += AddTransaction;
        DeleteButton.Click += DeleteTransaction;

        LoadCategories();
        RefreshUI();
    }

    private void TypeChanged(object? sender, SelectionChangedEventArgs e)
    {
        LoadCategories();
    }

    private void LoadCategories()
    {
        if (TypeBox.SelectedItem is ComboBoxItem selected)
        {
            string type = selected.Content?.ToString() ?? "";

            if (type == "Income")
                CategoryBox.ItemsSource = incomeCategories;
            else
                CategoryBox.ItemsSource = expenseCategories;

            CategoryBox.SelectedIndex = 0;
        }
    }

    private void AddTransaction(object? sender, RoutedEventArgs e)
    {
        if (!decimal.TryParse(AmountBox.Text, out decimal amount))
            return;

        if (TypeBox.SelectedItem is not ComboBoxItem selectedType)
            return;

        string type = selectedType.Content?.ToString() ?? "";

        string category = CategoryBox.SelectedItem?.ToString() ?? "";

        Transaction transaction = new()
        {
            Type = type,
            Category = category,
            Amount = amount,
            Note = NoteBox.Text ?? ""
        };

        _transactions.Add(transaction);

        _fileService.SaveTransactions(_transactions);

        AmountBox.Text = "";
        NoteBox.Text = "";

        RefreshUI();
    }

    private void DeleteTransaction(object? sender, RoutedEventArgs e)
    {
        if (TransactionList.SelectedIndex < 0)
            return;

        _transactions.RemoveAt(TransactionList.SelectedIndex);

        _fileService.SaveTransactions(_transactions);

        RefreshUI();
    }

    private void RefreshUI()
    {
        TransactionList.ItemsSource = _transactions
            .Select(t =>
                $"{t.Date:d} | {t.Type} | {t.Category} | ₹{t.Amount} | {t.Note}")
            .ToList();

        decimal income = _transactions
            .Where(t => t.Type == "Income")
            .Sum(t => t.Amount);

        decimal expenses = _transactions
            .Where(t => t.Type == "Expense")
            .Sum(t => t.Amount);

        IncomeText.Text = $"Income: ₹{income}";
        ExpenseText.Text = $"Expenses: ₹{expenses}";
        BalanceText.Text = $"Balance: ₹{income - expenses}";
    }
}