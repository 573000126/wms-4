package org.dddml.wms.domain.hibernate;

import java.io.Serializable;
import java.util.Date;
import org.dddml.wms.specialization.EventStoreAggregateId;
import org.dddml.wms.specialization.hibernate.AbstractHibernateEventStore;
import org.hibernate.*;
import org.dddml.wms.domain.*;

public class HibernateAttributeSetInstanceExtensionFieldGroupEventStore extends AbstractHibernateEventStore
{
    @Override
    protected Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version)
    {
        return new AttributeSetInstanceExtensionFieldGroupStateEventId((String) eventStoreAggregateId.getId(), version);
    }

    @Override
    protected Class getSupportedStateEventType()
    {
        return AbstractAttributeSetInstanceExtensionFieldGroupStateEvent.class;
    }

}

