﻿namespace MaxFlowOptimizeDemo.jsonStructures.graphComponents

{
    /// <summary>
    /// Record used to represent a pair of a Sink and a Commodity, read from the json of the problem.
    /// </summary>
    ///<param name="Sink">The name of the sink.</param>
    ///<param name="Commodity">The name of the commodity.</param>

    public record CommoditySink(string Sink, string Commodity);
}
