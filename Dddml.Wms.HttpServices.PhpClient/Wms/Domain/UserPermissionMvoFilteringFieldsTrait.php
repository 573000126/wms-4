﻿<?php

namespace Wms\Domain;


trait UserPermissionMvoFilteringFieldsTrait
{
    public function getFilteringFields()
    {
        return [
            'Version' => 'long',
            'CreatedBy' => 'string',
            'CreatedAt' => '\DateTime',
            'UpdatedBy' => 'string',
            'UpdatedAt' => '\DateTime',
            'Active' => 'boolean',
            'Deleted' => 'boolean',
            'UserUserName' => 'string',
            'UserAccessFailedCount' => 'integer',
            'UserEmail' => 'string',
            'UserEmailConfirmed' => 'boolean',
            'UserLockoutEnabled' => 'boolean',
            'UserLockoutEndDateUtc' => '\DateTime',
            'UserPasswordHash' => 'string',
            'UserPhoneNumber' => 'string',
            'UserPhoneNumberConfirmed' => 'boolean',
            'UserTwoFactorEnabled' => 'boolean',
            'UserSecurityStamp' => 'string',
            'UserVersion' => 'long',
            'UserCreatedBy' => 'string',
            'UserCreatedAt' => '\DateTime',
            'UserUpdatedBy' => 'string',
            'UserUpdatedAt' => '\DateTime',
            'UserActive' => 'boolean',
            'UserDeleted' => 'boolean',
            'UserPermissionId.UserId' => 'string',
            'UserPermissionId.PermissionId' => 'string',
        ];
    }

}

