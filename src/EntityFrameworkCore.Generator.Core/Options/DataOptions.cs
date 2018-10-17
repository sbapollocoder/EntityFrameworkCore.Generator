﻿using System;

namespace EntityFrameworkCore.Generator.Options
{
    /// <summary>
    /// The data options group
    /// </summary>
    public class DataOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataOptions"/> class.
        /// </summary>
        public DataOptions()
        {
            Mapping = new MappingClassOptions();
            Entity = new EntityClassOptions();
            Context = new ContextClassOptions();
            View = new ViewClassOptions();
            Query = new QueryExtensionOptions();
        }

        /// <summary>
        /// Gets or sets the data context generation options.
        /// </summary>
        /// <value>
        /// The data context options
        /// </value>
        public ContextClassOptions Context { get; set; }


        /// <summary>
        /// Gets or sets the entity class generation options.
        /// </summary>
        /// <value>
        /// The entity class generation options.
        /// </value>
        public EntityClassOptions Entity { get; set; }

        /// <summary>
        /// Gets or sets the mapping class generation options.
        /// </summary>
        /// <value>
        /// The mapping class generation options.
        /// </value>
        public MappingClassOptions Mapping { get; set; }

        /// <summary>
        /// Gets or sets the view class options.
        /// </summary>
        /// <value>
        /// The view class options.
        /// </value>
        public ViewClassOptions View { get; set; }

        /// <summary>
        /// Gets or sets the query extension options.
        /// </summary>
        /// <value>
        /// The query extension options.
        /// </value>
        public QueryExtensionOptions Query { get; set; }
    }
}