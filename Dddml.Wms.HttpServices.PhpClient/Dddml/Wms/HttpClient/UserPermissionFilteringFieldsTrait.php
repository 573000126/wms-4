<?php

namespace Dddml\Wms\HttpClient;


trait UserPermissionFilteringFieldsTrait
{
    public function getFilteringFields()
    {
        return [
            'Version' => 'Long',
            'CreatedBy' => 'string',
            'CreatedAt' => '\DateTime',
            'UpdatedBy' => 'string',
            'UpdatedAt' => '\DateTime',
            'Active' => 'boolean',
            'Deleted' => 'boolean',
            'UserId' => 'string',
            'UserPermissionId.UserId' => 'string',
            'UserPermissionId.PermissionId' => 'string',
        ];
    }

}

