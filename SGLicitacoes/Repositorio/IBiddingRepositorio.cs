using SGLicitacoes.Models;
using System.Collections.Generic;

namespace SGLicitacoes.Repositorio
{
    public interface IBiddingRepositorio
    {
        List<BiddingInfo> SearchBidding();
        BiddingInfo GetBiddingById(int id); 
        BiddingInfo AddBidding(BiddingInfo licitacao);
        BiddingInfo UpdateBiddingById(BiddingInfo licitacao);
        bool Delete(int id);
    
    }
}
