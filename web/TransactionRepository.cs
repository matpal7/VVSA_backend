using Microsoft.EntityFrameworkCore;
using web.DatabaseModel;
using web.ViewModel;
namespace web.Repository;

public class TransactionRepository : ITransactionRepository {

    private readonly Whiyes5oContext context;
    public TransactionRepository(Whiyes5oContext context) {
        this.context = context;
    }

    public List<Transaction> GetAllTransactions() {
        var result = context.Transactions
        .Include(p => p.User)
        .Include(p => p.TransactionType)
        .ToList();

        return result;
    }

    public Transaction GetTransactionById(int id) {
        var result = context.Transactions
        .Include(p => p.User)
        .Include(p => p.TransactionType)
        .FirstOrDefault(p => p.Id == id);

        return result;
    }
}