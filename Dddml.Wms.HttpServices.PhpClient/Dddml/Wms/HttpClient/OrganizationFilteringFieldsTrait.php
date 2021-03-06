<?php

namespace Dddml\Wms\HttpClient;


trait OrganizationFilteringFieldsTrait
{
    public function getFilteringFields()
    {
        return [
            'OrganizationId' => 'string',
            'Name' => 'string',
            'Description' => 'string',
            'Type' => 'string',
            'IsSummary' => 'boolean',
            'Version' => 'Long',
            'CreatedBy' => 'string',
            'CreatedAt' => '\DateTime',
            'UpdatedBy' => 'string',
            'UpdatedAt' => '\DateTime',
            'Active' => 'boolean',
            'Deleted' => 'boolean',
        ];
    }

}

