package org.dddml.wms.domain;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.specialization.DomainError;
import org.dddml.wms.domain.PermissionStateEvent.*;

public abstract class AbstractPermissionState implements PermissionState
{

    private String permissionId;

    public String getPermissionId()
    {
        return this.permissionId;
    }

    public void setPermissionId(String permissionId)
    {
        this.permissionId = permissionId;
    }

    private String name;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    private String parentPermissionId;

    public String getParentPermissionId()
    {
        return this.parentPermissionId;
    }

    public void setParentPermissionId(String parentPermissionId)
    {
        this.parentPermissionId = parentPermissionId;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean deleted;

    public Boolean getDeleted()
    {
        return this.deleted;
    }

    public void setDeleted(Boolean deleted)
    {
        this.deleted = deleted;
    }

    public boolean isStateUnsaved() 
    {
        return VERSION_ZERO.equals(this.getVersion());
    }


    public AbstractPermissionState()
    {
        initializeProperties();
    }
    
    protected void initializeProperties() {
    }


    public void mutate(Event e) {
        if (e instanceof PermissionStateCreated) {
            when((PermissionStateCreated) e);
        } else if (e instanceof PermissionStateMergePatched) {
            when((PermissionStateMergePatched) e);
        } else if (e instanceof PermissionStateDeleted) {
            when((PermissionStateDeleted) e);
        }
    }

    public abstract void when(PermissionStateCreated e);

    public abstract void when(PermissionStateMergePatched e);

    public abstract void when(PermissionStateDeleted e);


    protected void throwOnWrongEvent(PermissionStateEvent stateEvent)
    {
        String stateEntityId = this.getPermissionId(); // Aggregate Id
        String eventEntityId = stateEvent.getStateEventId().getPermissionId(); // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
        if (!stateEntityId.equals(eventEntityId))
        {
            DomainError.named("mutateWrongEntity", "Entity Id %1$s in state but entity id %2$s in event", stateEntityId, eventEntityId);
        }

        Long stateVersion = this.getVersion();
        Long eventVersion = stateEvent.getStateEventId().getVersion();
        if (!stateVersion.equals(eventVersion))
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version %1$s and event version %2$s", stateVersion, eventVersion);
        }

    }


}
