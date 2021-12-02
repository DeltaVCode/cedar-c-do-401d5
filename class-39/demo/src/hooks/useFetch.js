import { useEffect, useMemo, useState } from "react";

export default function useFetch(url) {
  // Store fetched data here
  const [loading, setLoading] = useState(true);
  const [data, setData] = useState(null);

  useEffect(() => {
    async function fetchData() {
      let response = await fetch(url);
      let body = await response.json();
      // TODO: error handling!
      setData(body);
      setLoading(false);
    };

    setLoading(true);
    fetchData();
  }, [url]) // Only re-fetch when url changes

  return useMemo(() => ({
    data,
    isLoading: loading,
  }), [data, loading]);
}
