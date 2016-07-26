package org.dddml.wms.domain.hibernate;

import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class HibernateUserPermissionStateDao implements UserPermissionStateDao
{
    public SessionFactory sessionFactory;

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public UserPermissionState get(UserPermissionId id)
    {
        UserPermissionState state = (UserPermissionState) getCurrentSession().get(AbstractUserPermissionState.SimpleUserPermissionState.class, id);
        if (state == null)
        {
            state = new AbstractUserPermissionState.SimpleUserPermissionState();
            state.setUserPermissionId(id);
        }
        return state;
    }

    @Override
    public void save(UserPermissionState state)
    {
        getCurrentSession().saveOrUpdate(state);
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public Iterable<UserPermissionState> findByUserId(String userId)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractUserPermissionState.SimpleUserPermissionState.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("userPermissionId.userId", userId))
            ;
        return criteria.add(partIdCondition).list();
    }

    @Override
    public void delete(UserPermissionState state)
    {
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
        getCurrentSession().delete(state);
    }

}
