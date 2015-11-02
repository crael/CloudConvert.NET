﻿namespace Aliencube.CloudConvert.Wrapper.Responses
{
    /// <summary>
    /// Represents a response from a conversion status request.
    /// </summary>
    public class ConversionStatusResponse : ConvertResponse
    {
        /// <summary>
        /// Gets or sets the process identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the conversion percentage.
        /// </summary>
        /// <value>
        /// The percent.
        /// </value>
        public string Percent { get; set; }

        /// <summary>
        /// Gets or sets the conversion message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the conversion step.
        /// </summary>
        /// <value>
        /// The step.
        /// </value>
        public ConversionStep Step { get; set; }

        /// <summary>
        /// Gets or sets the conversion start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public long StartTime { get; set; }

        /// <summary>
        /// Gets or sets the conversion end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public long? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the conversion expiration time.
        /// </summary>
        /// <value>
        /// The expiration time.
        /// </value>
        public long Expire { get; set; }

        /// <summary>
        /// Gets or sets the input status.
        /// </summary>
        /// <value>
        /// The input status.
        /// </value>
        public InputStatus Input { get; set; }

        /// <summary>
        /// Gets or sets the converter status.
        /// </summary>
        /// <value>
        /// The converter status.
        /// </value>
        public ConverterStatus Converter { get; set; }

        /// <summary>
        /// Gets or sets the output status.
        /// </summary>
        /// <value>
        /// The output status.
        /// </value>
        public OutputStatus Output { get; set; }
    }
}
