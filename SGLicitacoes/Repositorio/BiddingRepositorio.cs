using SGLicitacoes.Data;
using SGLicitacoes.Models;
using System;
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

        public BiddingInfo GetBiddingById(int id)
        {

            return _bancoContext.Licitacao.FirstOrDefault(b => b.Id == id);
        }

        public BiddingInfo UpdateBiddingById(BiddingInfo licitacao)
        {
            BiddingInfo licitacaoDB = GetBiddingById(licitacao.Id);

            if (licitacaoDB == null)
            {
                throw new ArgumentException("Houve um erro na atualização da Licitação");
            }
            else
            {
                licitacaoDB.Id = licitacao.Id;
                licitacaoDB.Description = licitacao.Description;
                licitacaoDB.Status = licitacao.Status;
                _bancoContext.Licitacao.Update(licitacaoDB);
                _bancoContext.SaveChanges();
                return licitacaoDB;

            }

        }

        public bool Delete(int id)
        {
            BiddingInfo licitacaoDB = GetBiddingById(id);

            if (licitacaoDB == null)
            {
                throw new ArgumentException("Houve um erro na apagar a Licitação");
            }
            else
            {

                _bancoContext.Remove(licitacaoDB);
                _bancoContext.SaveChanges();
                return true;

            }
        }
    }
}
