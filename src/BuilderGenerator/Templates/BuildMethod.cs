        public override {{TargetClassFullName}} Build()
        {
            if ({{TargetClassName}}?.IsValueCreated != true)
            {
                {{TargetClassName}} = new System.Lazy<{{TargetClassFullName}}>(() =>
                {
                    var result = new {{TargetClassFullName}}{{ConstructorParameters}}{{ObjectInitializer}};

                    return result;
                });

                if (PostBuildAction != null)
                {
                    PostBuildAction({{TargetClassName}}.Value);
                }
            }

            return {{TargetClassName}}.Value;
        }
