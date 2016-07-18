﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\CommandTrait;

class RemoveUserPermission extends CreateOrMergePatchUserPermission
{

    /**
     * @return string
     */
    public function getCommandType()
    {
        return 'Remove';
    }


}

