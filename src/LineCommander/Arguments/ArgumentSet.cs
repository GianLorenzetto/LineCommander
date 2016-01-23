using System;
using System.Collections.Generic;

namespace LineCommander.Arguments
{
    public class ArgumentSet
    {
        private readonly List<Action> _requiredActions = new List<Action>();
        private readonly List<Action> _otherActions = new List<Action>();
        private readonly List<Option> _requiredOptions = new List<Option>();
        private readonly List<Option> _otherOptions = new List<Option>();

        public bool Parse(string[] args)
        {
            return false;
        }

        public ArgumentSet AddRequired(Action action)
        {
            if (_requiredActions.Contains(action))
                throw new ArgumentException($"ArgumentSet already contains required Action '{action.Name}'");

            if (_otherActions.Contains(action))
                throw new ArgumentException($"Cannot add required action '{action.Name}' - action previously added as optional");

            _requiredActions.Add(action);
            return this;
        }

        public ArgumentSet AddOptional(Action action)
        {
            if (_requiredActions.Contains(action))
                throw new ArgumentException($"Cannot add optional action '{action.Name}' - action previously added as required");

            if (_otherActions.Contains(action))
                throw new ArgumentException($"ArgumentSet already contains optional Action '{action.Name}'");

            _otherActions.Add(action);
            return this;
        }

        public ArgumentSet AddRequired(Option option)
        {
            if (_requiredOptions.Contains(option))
                throw new ArgumentException($"ArgumentSet already contains required option '{option.Name}'");

            if (_requiredOptions.Contains(option))
                throw new ArgumentException($"Cannot add required option '{option.Name}' - option previously added as optional");

            _requiredOptions.Add(option);
            return this;
        }

        public ArgumentSet AddOptional(Option option)
        {
            if (_requiredOptions.Contains(option))
                throw new ArgumentException($"Cannot add optional option '{option.Name}' - option previously added as required");

            if (_requiredOptions.Contains(option))
                throw new ArgumentException($"ArgumentSet already contains optional Action '{option.Name}'");

            _otherOptions.Add(option);
            return this;
        }
    }
}
