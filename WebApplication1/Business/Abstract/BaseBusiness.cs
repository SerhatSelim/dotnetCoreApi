using AutoMapper;

namespace Business.Abstract
{
 
    public abstract class BaseBusiness 
    {
        protected readonly IMapper mapper;

        protected BaseBusiness(IMapper mapper)
        {
            this.mapper = mapper;
        }

    }
}

