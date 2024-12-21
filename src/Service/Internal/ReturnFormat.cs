namespace OpenSky.Core.Service.Internal;

/// <summary>
/// Specifies the format in which the response should be returned.
/// </summary>
internal enum ReturnFormat
{
    /// <summary>
    /// The response is returned as an entity.
    /// </summary>
    Entity = 1,

    /// <summary>
    /// The response is returned in JSON format.
    /// </summary>
    Json = 2,

    /// <summary>
    /// The response is returned in XML format.
    /// </summary>
    Xml = 3
}