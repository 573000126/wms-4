package org.dddml.wms.domain;


public class DeleteInOutLineMvoDto extends AbstractInOutLineMvoCommandDto
{

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

}

