<?php

namespace Dddml\Wms\Domain;

use Dddml\Command\CommandInterface;
use JMS\Serializer\Annotation\Type;
use Dddml\Serializer\Type\Long;
use Dddml\Wms\Domain\CommandTrait;

abstract class AbstractUserPermissionMvoCommand implements CommandInterface
{

    use CommandTrait;

    /**
     * @Type("Dddml\Wms\Domain\UserPermissionId")
     */
    private $userPermissionId;

    /**
     * @return UserPermissionId
     */
    public function getUserPermissionId()
    {
        return $this->userPermissionId;
    }

    /**
     * @param UserPermissionId $userPermissionId
     */
    public function setUserPermissionId($userPermissionId)
    {
        $this->userPermissionId = $userPermissionId;
    }

    /**
     * @Type("Dddml\Serializer\Type\Long")
     */
    private $userVersion;

    /**
     * @return Long
     */
    public function getUserVersion()
    {
        return $this->userVersion;
    }

    /**
     * @param Long $userVersion
     */
    public function setUserVersion($userVersion)
    {
        $this->userVersion = $userVersion;
    }


}

