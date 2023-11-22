using SGLicitacoes.Models;
using System.Collections.Generic;

namespace SGLicitacoes.Repositorio
{
    public interface IBiddingRepositorio
    {
        List<BiddingInfo> SearchBidding();
        BiddingInfo AddBidding(BiddingInfo licitacao);
    
    }
}
