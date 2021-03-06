<?php

namespace Dddml\Wms\HttpClient;

use Dddml\Serializer\Type\Long;

class RoleQueryRequest extends AbstractQueryRequest
{
    use RoleFilteringFieldsTrait;

    protected $routePath = 'Roles/{id}';

    public function getReturnType()
    {
        return 'Dddml\Wms\Domain\Role';
    }
}

