using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.EntityFrameworkCore.Core
{
    /// <summary>
    /// 工作单元
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 开启事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task BeginTransactionAsync(CancellationToken cancellationToken=default);
        /// <summary>
        /// 保存事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task CommitTransactionAsync(CancellationToken cancellationToken=default);
        /// <summary>
        /// 回滚事务
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RollbackTransactionAsync(CancellationToken cancellationToken=default);
    }
    
}