package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class AttributeFilteringProperties
{

    private AttributeFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "AttributeId",
            "Name",
            "OrganizationId",
            "Description",
            "IsMandatory",
            "IsInstanceAttribute",
            "AttributeValueType",
            "AttributeValueLength",
            "IsList",
            "FieldName",
            "ReferenceId",
            "Version",
            "CreatedBy",
            "CreatedAt",
            "UpdatedBy",
            "UpdatedAt",
            "Active",
            "Deleted",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "String",
            "String",
            "Boolean",
            "Boolean",
            "String",
            "Integer",
            "Boolean",
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
    };

    public static final Map<String, String> propertyTypeMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}
