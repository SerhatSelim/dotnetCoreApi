using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ActionFilters
{
    public class LogFilter : ActionFilterAttribute
    {
        private readonly Logger logger;

        public LogFilter()
        {
            this.logger = LogManager.GetCurrentClassLogger();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            this.logger.Warn("OnActionExecuted");
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.logger.Warn("OnActionExecuting");

            base.OnActionExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            this.logger.Warn("OnResultExecuted");

            base.OnResultExecuted(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            this.logger.Warn("OnResultExecuting");

            base.OnResultExecuting(context);
        }

        
    }
}
