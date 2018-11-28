using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.IDAO
{
    public interface IBaseDao<T>
                  where T : class,
                 new()//约束T类型必须可以实例化
    {
        //根据条件获取实体对象集合
        IQueryable<T> LoadEntites();
        //千万别用下面两种方式去查询，因为这两种方式是吧整个表所有的数据查出来后再按条件筛选的　　　
        //IQueryable<T> LoadEntites(Func<T,bool> whereLambda );
        //IQueryable<T> LoadEntites(Func<T,bool> whereLambda, int pageIndex, int pageSize,out int totalCount); 

        //增加  
        T AddEntity(T entity);
        //更新  
        T UpdateEntity(T entity);
        //删除 
        bool DelEntity(T entity);
        //根据条件删除
        bool DelEntityByWhere(Func<T, bool> whereLambda);
    }
}