using Rabbit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.Service
{
    public interface IGalleryServicecs
    {
        List<Gallery> GetAll();
    }
}
