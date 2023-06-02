using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmReservaItemAcervo
{

	public class ItemAcervoModel
	{
		public string CodItem { get; set; }
		public string NomeItem { get; set; }
		public string NumExemplar { get; set; }
		public string TipoItem { get; set; }
		public string Localizacao { get; set; }


	}
}

