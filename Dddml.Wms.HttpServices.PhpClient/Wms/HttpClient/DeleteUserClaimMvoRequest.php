﻿<?php

namespace Wms\HttpClient;

use Dddml\Command\CommandExecutor;
use Dddml\Executor\Http\CommandRequestInterface;
use Dddml\Routing\RouteTrait;
use Symfony\Component\Routing\Route;
use Wms\Domain\UserClaimId;
use Wms\Domain\UserRole;
use Wms\Domain\UserClaim;
use Wms\Domain\UserPermission;
use Wms\Domain\UserLogin;
use Wms\Domain\DeleteUserClaimMvo;


class DeleteUserClaimMvoRequest implements CommandRequestInterface
{
    use RouteTrait;

    /**
     * @var DeleteUserClaimMvo
     */
    private $command;

    public function __construct()
    {
        $this->route = new Route('UserClaimMvos/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_DELETE;
    }

    /**
     * @return DeleteUserClaimMvo
     */
    public function getCommand()
    {
        if (!$this->command) {
            $this->command = new DeleteUserClaimMvo();
        }

        return $this->command;
    }

}

