using SGLicitacoes.Data;
using SGLicitacoes.Models;
using System.Collections.Generic;
using System.Linq;

namespace SGLicitacoes.Repositorio
{
    public class BiddingRepositorio : IBiddingRepositorio
    {
        private readonly BancoContext _bancoContext;

        public BiddingRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<BiddingInfo> SearchBidding()
        {
            return _bancoContext.Licitacao.ToList();
        }

        public BiddingInfo AddBidding(BiddingInfo licitacao)
        {
            _bancoContext.Licitacao.Add(licitacao);
            _bancoContext.SaveChanges();
            return licitacao;
        }
    }
}
