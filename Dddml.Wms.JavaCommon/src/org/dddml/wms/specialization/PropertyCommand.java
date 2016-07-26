package org.dddml.wms.specialization;

import java.util.function.Supplier;
import java.util.function.Consumer;

/**
 * Created by Yang on 2016/7/25.
 */
public interface PropertyCommand <TContent, TState>
{
    TContent getContent();

    void setContent(TContent content);

    Supplier<TState> getStateGetter();

    void setStateGetter(Supplier<TState> stateGetter);

    Consumer<TState> getStateSetter();

    void setStateSetter(Consumer<TState> stateSetter);

    String getOuterCommandType();

    void setOuterCommandType(String type);

}
