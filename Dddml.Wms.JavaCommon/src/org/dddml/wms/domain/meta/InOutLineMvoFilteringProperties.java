package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class InOutLineMvoFilteringProperties
{

    private InOutLineMvoFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "lineNumber",
            "description",
            "locatorId",
            "product",
            "uomId",
            "movementQuantity",
            "confirmedQuantity",
            "scrappedQuantity",
            "targetQuantity",
            "pickedQuantity",
            "isInvoiced",
            "attributeSetInstanceId",
            "isDescription",
            "processed",
            "quantityEntered",
            "rmaLineNumber",
            "reversalLineNumber",
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
            "inOutIsSOTransaction",
            "inOutDocumentStatus",
            "inOutPosted",
            "inOutProcessing",
            "inOutProcessed",
            "inOutDocumentType",
            "inOutDescription",
            "inOutOrderNumber",
            "inOutDateOrdered",
            "inOutIsPrinted",
            "inOutMovementType",
            "inOutMovementDate",
            "inOutBusinessPartnerId",
            "inOutWarehouseId",
            "inOutPOReference",
            "inOutFreightAmount",
            "inOutShipperId",
            "inOutChargeAmount",
            "inOutDatePrinted",
            "inOutSalesRepresentative",
            "inOutNumberOfPackages",
            "inOutPickDate",
            "inOutShipDate",
            "inOutTrackingNumber",
            "inOutDateReceived",
            "inOutIsInTransit",
            "inOutIsApproved",
            "inOutIsInDispute",
            "inOutVolume",
            "inOutWeight",
            "inOutRmaNumber",
            "inOutReversalNumber",
            "inOutIsDropShip",
            "inOutDropShipBusinessPartnerId",
            "inOutVersion",
            "inOutCreatedBy",
            "inOutCreatedAt",
            "inOutUpdatedBy",
            "inOutUpdatedAt",
            "inOutActive",
            "inOutDeleted",
            "inOutLineId.inOutDocumentNumber",
            "inOutLineId.skuIdProductId",
            "inOutLineId.skuIdAttributeSetInstanceId",
            "inOutFreightAmount.amount",
            "inOutFreightAmount.currency",
            "inOutChargeAmount.amount",
            "inOutChargeAmount.currency",
    };

    public static final String[] propertyTypes = new String[] {
            "Long",
            "String",
            "String",
            "String",
            "String",
            "BigDecimal",
            "BigDecimal",
            "BigDecimal",
            "BigDecimal",
            "BigDecimal",
            "Boolean",
            "String",
            "Boolean",
            "Boolean",
            "BigDecimal",
            "Long",
            "Long",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "Boolean",
            "String",
            "Boolean",
            "Boolean",
            "Boolean",
            "Integer",
            "String",
            "String",
            "Date",
            "Boolean",
            "String",
            "Date",
            "String",
            "String",
            "String",
            "Money",
            "String",
            "Money",
            "Date",
            "String",
            "Integer",
            "Date",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "Boolean",
            "BigDecimal",
            "BigDecimal",
            "String",
            "String",
            "Boolean",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
            "BigDecimal",
            "String",
            "BigDecimal",
            "String",
    };

    public static final Map<String, String> propertyTypeMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

