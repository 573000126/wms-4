<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Dddml\FlattenedDtoInterface;

class UserLoginIdFlattenedDto implements FlattenedDtoInterface
{

    const PROPERTIES = [
            'userId' => 'string',
            'loginKeyLoginProvider' => 'string',
            'loginKeyProviderKey' => 'string',
        ];

    public static function getPropertyNames()
    {
        return array_keys(static::PROPERTIES);
    }

    public static function getPropertyTypes()
    {
        return array_values(static::PROPERTIES);
    }

	
    /**
     * @var UserLoginId
     */
    private $value;

    /**
     * @param UserLoginId $value
     */
    public function __construct(UserLoginId $value = null)
    {
        if ($value) {
            $this->value = $value;
        } else {
            $this->value = new UserLoginId();
        }
    }

    /**
     * @return UserLoginId
     */
    public function toUserLoginId()
    {
        return $this->value;
    }

    /**
     * @return string
     */
    public function getUserId()
    {
        return $this->value->getUserId();
    }

    /**
     * @param string $userId
     */
    public function setUserId($userId)
    {
        $this->value->setUserId($userId);
    }

    /**
     * @return string
     */
    public function getLoginKeyLoginProvider()
    {
        return $this->value->getLoginKey()->getLoginProvider();
    }

    /**
     * @param string $loginKeyLoginProvider
     */
    public function setLoginKeyLoginProvider($loginKeyLoginProvider)
    {
        $this->value->getLoginKey()->setLoginProvider($loginKeyLoginProvider);
    }

    /**
     * @return string
     */
    public function getLoginKeyProviderKey()
    {
        return $this->value->getLoginKey()->getProviderKey();
    }

    /**
     * @param string $loginKeyProviderKey
     */
    public function setLoginKeyProviderKey($loginKeyProviderKey)
    {
        $this->value->getLoginKey()->setProviderKey($loginKeyProviderKey);
    }

    /**
     * @return string
     */
    public function toString()
    {
        $pValues = [
            $this->getUserId(),
            $this->getLoginKeyLoginProvider(),
            $this->getLoginKeyProviderKey(),
        ];
        return implode(',', $pValues);
    }

    /**
     * @param string $data
     *
     * @return UserLoginIdFlattenedDto
     */
    public function fromString($data)
    {
        $pValues = explode(',', $data);
        $this->setUserId($pValues[0]);
        $this->setLoginKeyLoginProvider($pValues[1]);
        $this->setLoginKeyProviderKey($pValues[2]);
        return $this;
    }

}

