import { useEffect, useMemo, useState } from "react";

export default function useFetch(url) {
  // Store fetched data here
  const [loading, setLoading] = useState(true);
  const [shouldFetch, setShouldFetch] = useState(true);
  const [data, setData] = useState(null);

  useEffect(() => {
    // Only fetch if actually loading
    if (!shouldFetch) return;

    async function fetchData() {

      let response = await fetch(url);
      let body = await response.json();
      // TODO: error handling!
      setData(body);
      setLoading(false);
    };

    setShouldFetch(false);
    fetchData();
  }, [url, shouldFetch]) // Only re-fetch when url changes

  return useMemo(() => ({
    data,
    isLoading: loading,
    reload: () => setShouldFetch(true),
  }), [data, loading]);
}
