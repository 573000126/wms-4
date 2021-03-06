<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;

trait AttributeSetIsPropertyRemovedTrait
{
    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyNameRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyNameRemoved()
    {
        return $this->isPropertyNameRemoved;
    }

    /**
     * @param boolean $isPropertyNameRemoved
     */
    public function setIsPropertyNameRemoved($isPropertyNameRemoved)
    {
        $this->isPropertyNameRemoved = $isPropertyNameRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyOrganizationIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyOrganizationIdRemoved()
    {
        return $this->isPropertyOrganizationIdRemoved;
    }

    /**
     * @param boolean $isPropertyOrganizationIdRemoved
     */
    public function setIsPropertyOrganizationIdRemoved($isPropertyOrganizationIdRemoved)
    {
        $this->isPropertyOrganizationIdRemoved = $isPropertyOrganizationIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyDescriptionRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyDescriptionRemoved()
    {
        return $this->isPropertyDescriptionRemoved;
    }

    /**
     * @param boolean $isPropertyDescriptionRemoved
     */
    public function setIsPropertyDescriptionRemoved($isPropertyDescriptionRemoved)
    {
        $this->isPropertyDescriptionRemoved = $isPropertyDescriptionRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertySerialNumberAttributeIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertySerialNumberAttributeIdRemoved()
    {
        return $this->isPropertySerialNumberAttributeIdRemoved;
    }

    /**
     * @param boolean $isPropertySerialNumberAttributeIdRemoved
     */
    public function setIsPropertySerialNumberAttributeIdRemoved($isPropertySerialNumberAttributeIdRemoved)
    {
        $this->isPropertySerialNumberAttributeIdRemoved = $isPropertySerialNumberAttributeIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyLotAttributeIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyLotAttributeIdRemoved()
    {
        return $this->isPropertyLotAttributeIdRemoved;
    }

    /**
     * @param boolean $isPropertyLotAttributeIdRemoved
     */
    public function setIsPropertyLotAttributeIdRemoved($isPropertyLotAttributeIdRemoved)
    {
        $this->isPropertyLotAttributeIdRemoved = $isPropertyLotAttributeIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyReferenceIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyReferenceIdRemoved()
    {
        return $this->isPropertyReferenceIdRemoved;
    }

    /**
     * @param boolean $isPropertyReferenceIdRemoved
     */
    public function setIsPropertyReferenceIdRemoved($isPropertyReferenceIdRemoved)
    {
        $this->isPropertyReferenceIdRemoved = $isPropertyReferenceIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyActiveRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyActiveRemoved()
    {
        return $this->isPropertyActiveRemoved;
    }

    /**
     * @param boolean $isPropertyActiveRemoved
     */
    public function setIsPropertyActiveRemoved($isPropertyActiveRemoved)
    {
        $this->isPropertyActiveRemoved = $isPropertyActiveRemoved;
    }


}

