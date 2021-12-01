import useAuth from "../../hooks/useAuth"

export default function Auth(props) {
  const { hasPermission } = useAuth();
  const { permission, children } = props;

  if (hasPermission(permission))
    return children;

  return null;
}