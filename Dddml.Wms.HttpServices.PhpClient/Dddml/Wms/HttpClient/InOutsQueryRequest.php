<?php

namespace Dddml\Wms\HttpClient;

use Dddml\Serializer\Type\Money;
use Dddml\Serializer\Type\Decimal;
use Dddml\Serializer\Type\Long;
use Dddml\Executor\Http\QueryCountRequestInterface;

class InOutsQueryRequest extends AbstractQueryRequest implements QueryCountRequestInterface
{
    use InOutFilteringFieldsTrait;

    protected $routePath = 'InOuts';

    public function getReturnType()
    {
        return 'array<Dddml\Wms\Domain\InOut>';
    }
}

