<?php

namespace Dddml\Wms\Domain;

use JMS\Serializer\Annotation\Type;

trait AttributeValueMvoIsPropertyRemovedTrait
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
    private $isPropertyVersionRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyVersionRemoved()
    {
        return $this->isPropertyVersionRemoved;
    }

    /**
     * @param boolean $isPropertyVersionRemoved
     */
    public function setIsPropertyVersionRemoved($isPropertyVersionRemoved)
    {
        $this->isPropertyVersionRemoved = $isPropertyVersionRemoved;
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

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeNameRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeNameRemoved()
    {
        return $this->isPropertyAttributeNameRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeNameRemoved
     */
    public function setIsPropertyAttributeNameRemoved($isPropertyAttributeNameRemoved)
    {
        $this->isPropertyAttributeNameRemoved = $isPropertyAttributeNameRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeOrganizationIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeOrganizationIdRemoved()
    {
        return $this->isPropertyAttributeOrganizationIdRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeOrganizationIdRemoved
     */
    public function setIsPropertyAttributeOrganizationIdRemoved($isPropertyAttributeOrganizationIdRemoved)
    {
        $this->isPropertyAttributeOrganizationIdRemoved = $isPropertyAttributeOrganizationIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeDescriptionRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeDescriptionRemoved()
    {
        return $this->isPropertyAttributeDescriptionRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeDescriptionRemoved
     */
    public function setIsPropertyAttributeDescriptionRemoved($isPropertyAttributeDescriptionRemoved)
    {
        $this->isPropertyAttributeDescriptionRemoved = $isPropertyAttributeDescriptionRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeIsMandatoryRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeIsMandatoryRemoved()
    {
        return $this->isPropertyAttributeIsMandatoryRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeIsMandatoryRemoved
     */
    public function setIsPropertyAttributeIsMandatoryRemoved($isPropertyAttributeIsMandatoryRemoved)
    {
        $this->isPropertyAttributeIsMandatoryRemoved = $isPropertyAttributeIsMandatoryRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeIsInstanceAttributeRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeIsInstanceAttributeRemoved()
    {
        return $this->isPropertyAttributeIsInstanceAttributeRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeIsInstanceAttributeRemoved
     */
    public function setIsPropertyAttributeIsInstanceAttributeRemoved($isPropertyAttributeIsInstanceAttributeRemoved)
    {
        $this->isPropertyAttributeIsInstanceAttributeRemoved = $isPropertyAttributeIsInstanceAttributeRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeAttributeValueTypeRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeAttributeValueTypeRemoved()
    {
        return $this->isPropertyAttributeAttributeValueTypeRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeAttributeValueTypeRemoved
     */
    public function setIsPropertyAttributeAttributeValueTypeRemoved($isPropertyAttributeAttributeValueTypeRemoved)
    {
        $this->isPropertyAttributeAttributeValueTypeRemoved = $isPropertyAttributeAttributeValueTypeRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeAttributeValueLengthRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeAttributeValueLengthRemoved()
    {
        return $this->isPropertyAttributeAttributeValueLengthRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeAttributeValueLengthRemoved
     */
    public function setIsPropertyAttributeAttributeValueLengthRemoved($isPropertyAttributeAttributeValueLengthRemoved)
    {
        $this->isPropertyAttributeAttributeValueLengthRemoved = $isPropertyAttributeAttributeValueLengthRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeIsListRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeIsListRemoved()
    {
        return $this->isPropertyAttributeIsListRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeIsListRemoved
     */
    public function setIsPropertyAttributeIsListRemoved($isPropertyAttributeIsListRemoved)
    {
        $this->isPropertyAttributeIsListRemoved = $isPropertyAttributeIsListRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeFieldNameRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeFieldNameRemoved()
    {
        return $this->isPropertyAttributeFieldNameRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeFieldNameRemoved
     */
    public function setIsPropertyAttributeFieldNameRemoved($isPropertyAttributeFieldNameRemoved)
    {
        $this->isPropertyAttributeFieldNameRemoved = $isPropertyAttributeFieldNameRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeReferenceIdRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeReferenceIdRemoved()
    {
        return $this->isPropertyAttributeReferenceIdRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeReferenceIdRemoved
     */
    public function setIsPropertyAttributeReferenceIdRemoved($isPropertyAttributeReferenceIdRemoved)
    {
        $this->isPropertyAttributeReferenceIdRemoved = $isPropertyAttributeReferenceIdRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeCreatedByRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeCreatedByRemoved()
    {
        return $this->isPropertyAttributeCreatedByRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeCreatedByRemoved
     */
    public function setIsPropertyAttributeCreatedByRemoved($isPropertyAttributeCreatedByRemoved)
    {
        $this->isPropertyAttributeCreatedByRemoved = $isPropertyAttributeCreatedByRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeCreatedAtRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeCreatedAtRemoved()
    {
        return $this->isPropertyAttributeCreatedAtRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeCreatedAtRemoved
     */
    public function setIsPropertyAttributeCreatedAtRemoved($isPropertyAttributeCreatedAtRemoved)
    {
        $this->isPropertyAttributeCreatedAtRemoved = $isPropertyAttributeCreatedAtRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeUpdatedByRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeUpdatedByRemoved()
    {
        return $this->isPropertyAttributeUpdatedByRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeUpdatedByRemoved
     */
    public function setIsPropertyAttributeUpdatedByRemoved($isPropertyAttributeUpdatedByRemoved)
    {
        $this->isPropertyAttributeUpdatedByRemoved = $isPropertyAttributeUpdatedByRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeUpdatedAtRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeUpdatedAtRemoved()
    {
        return $this->isPropertyAttributeUpdatedAtRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeUpdatedAtRemoved
     */
    public function setIsPropertyAttributeUpdatedAtRemoved($isPropertyAttributeUpdatedAtRemoved)
    {
        $this->isPropertyAttributeUpdatedAtRemoved = $isPropertyAttributeUpdatedAtRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeActiveRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeActiveRemoved()
    {
        return $this->isPropertyAttributeActiveRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeActiveRemoved
     */
    public function setIsPropertyAttributeActiveRemoved($isPropertyAttributeActiveRemoved)
    {
        $this->isPropertyAttributeActiveRemoved = $isPropertyAttributeActiveRemoved;
    }

    /**
     * @Type("boolean")
     *
     * @var boolean
     */
    private $isPropertyAttributeDeletedRemoved = false;

    /**
     * @return boolean
     */
    public function getIsPropertyAttributeDeletedRemoved()
    {
        return $this->isPropertyAttributeDeletedRemoved;
    }

    /**
     * @param boolean $isPropertyAttributeDeletedRemoved
     */
    public function setIsPropertyAttributeDeletedRemoved($isPropertyAttributeDeletedRemoved)
    {
        $this->isPropertyAttributeDeletedRemoved = $isPropertyAttributeDeletedRemoved;
    }


}

